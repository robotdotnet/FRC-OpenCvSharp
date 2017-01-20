#include "include_opencv.h"

CVAPI(void) frc_cvtColor(cv::_InputArray* input, cv::_OutputArray* output, int code, int dstCn)
{
    cv::cvtColor(*input, *output, code, dstCn);
}

CVAPI(void) frc_inRange(cv::_InputArray* input, CvScalar lowerb, CvScalar upperb, cv::_OutputArray* output)
{
    cv::inRange(*input, cv::Scalar(lowerb), cv::Scalar(upperb), *output);
}

CVAPI(void) frc_findContours_noHierarchy(cv::_InputOutputArray * input, std::vector<std::vector<cv::Point> > *contours, int mode,
    int method, CvPoint offset)
{
    cv::findContours(*input, *contours, mode, method, offset);
}

CVAPI(void) frc_findContours_Hierarchy(cv::_InputOutputArray * input, std::vector<std::vector<cv::Point> > *contours, std::vector<cv::Vec4i> **hierarchy,
    int mode, int method, CvPoint offset)
{
    *hierarchy = new std::vector<cv::Vec4i>;
    cv::findContours(*input, *contours, **hierarchy, mode, method, offset);
}

CVAPI(void) frc_convexHull_vector(std::vector<cv::Point> *contours, std::vector<cv::Point> *hulls,
    int clockwise, int returnPoints)
{
    cv::convexHull(*contours, *hulls, clockwise != 0, returnPoints != 0);
}

CVAPI(void) frc_convexHull_all_vector(std::vector<std::vector<cv::Point> > *contours, std::vector<std::vector<cv::Point> > *hulls,
    int clockwise, int returnPoints)
{
    hulls->clear();
    hulls->reserve(contours->size());
    int count = 0;
    for (auto&& i : *contours) {
        hulls->emplace_back();
        cv::convexHull(i, hulls->at(count), clockwise != 0, returnPoints != 0);
    }
}

CVAPI(void) frc_findContours_convexHull(cv::_InputOutputArray * input, std::vector<std::vector<cv::Point> > *contours, std::vector<std::vector<cv::Point> > *hulls, int mode,
    int method, CvPoint offset, int clockwise, int returnPoints)
{
    cv::findContours(*input, *contours, mode, method, offset);
    hulls->clear();
    hulls->reserve(contours->size());
    int count = 0;
    for (auto&& i : *contours) {
        hulls->emplace_back();
        cv::convexHull(i, hulls->at(count), clockwise != 0, returnPoints != 0);
        count++;
    }
}

CVAPI(void) frc_drawContours(cv::_InputOutputArray *image,
	std::vector<std::vector<cv::Point> >*contours, 
	int contourIdx, CvScalar color, int thickness, int lineType,
	cv::Vec4i *hierarchy, int hiearchyLength, int maxLevel, CvPoint offset)
{
    std::vector<cv::Vec4i> hiearchyVec;
	if (hierarchy != NULL)
	{
		hiearchyVec = std::vector<cv::Vec4i>(hierarchy, hierarchy + hiearchyLength);
	}

	cv::drawContours(*image, *contours, contourIdx, cv::Scalar(color), thickness, lineType, hiearchyVec, maxLevel, offset);
}
