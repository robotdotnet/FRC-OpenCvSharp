#include "include_opencv.h"

CVAPI(void) frc_cvtColor(cv::Mat* input, cv::Mat* output, int code, int dstCn)
{
    cv::cvtColot(*input, *output, code, dstCn);
}

CVAPI(void) frc_inRange(cv::Mat* input, CvScalar lower, CvScaler upper, cv::Mat* output)
{
    cv::inRange(*input, lower, upper, *output);
}

CVAPI(void) frc_findContours_noHierarchy(cv:Mat * input, std::vector<std::vector<cv::Point> > *contours, int mode,
    int method, CvPoint offset)
{
    cv::findContours(*input, *contours, mode, method, offset);
}

CVAPI(void) frc_findContours_Hierarchy(cv:Mat * input, std::vector<std::vector<cv::Point> > *contours, std::vector<cv::Vec4i> **hierarchy
int mode, int method, CvPoint offset)
{
    *hierarchy = new std::vector<cv::Vec4i>;
    cv::findContours(*image, *contours, **hierarchy, mode, method, offset);
}

CVAPI(void) frc_convexHull_vector(std::vector<std::vector<cv::Point> > *contours, std::vector<std::vector<cv::Point> > *hulls,
    int clockwise, int returnPoints)
{
    cv::convexHull(*points, *hull, clockwise != 0, returnPoints != 0);
}

CVAPI(void) frc_convexHull_pointArray(cv::Point *contours, cv::Point *hulls,
    int clockwise, int returnPoints)
{
    cv::convexHull(points, hull, clockwise != 0, returnPoints != 0);
}